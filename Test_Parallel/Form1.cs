using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Parallel
{
    public partial class Form1 : Form
    {
        enum enCase
        {
            nfor,
            pFor,
            pForeach,
            pInvoke,
        }

        #region
        private int _iThreadSleepTime = 10;

        private int _iforStart = 0;
        private int _iforCount = 100;

        DateTime startTime;  // 작업 시작 시각
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            pThread(enCase.nfor);
        }

        private void btnParallelFor_Click(object sender, EventArgs e)
        {
            pThread(enCase.pFor);
        }

        private void btnParallelForeach_Click(object sender, EventArgs e)
        {
            pThread(enCase.pForeach);
        }

        private void btnParallelInvoke_Click(object sender, EventArgs e)
        {
            pThread(enCase.pInvoke);
        }

        
        // Thread
        private void pThread(enCase eCase)
        {
            Log(lboxTime, enLogLevel.Info, string.Format("Thread Start"));
            startTime = DateTime.Now;  

            Thread _thread;

            switch (eCase)
            {
                case enCase.nfor:
                    _thread = new Thread(Tnfor);
                    _thread.Start();
                    break;

                case enCase.pFor:
                    _thread = new Thread(TpFor);
                    _thread.Start();
                    break;
                case enCase.pForeach:
                    _thread = new Thread(TpForeach);
                    _thread.Start();
                    break;
                case enCase.pInvoke:
                    _thread = new Thread(TpInvoke);
                    _thread.Start();
                    break;
            }
        }


        #region 분산처리 Ex
        // 그냥 for문(분산처리 아님. 순차대로 처리됨)
        private void Tnfor()
        {
            for (int i = _iforStart; i < _iforCount; i++)
            {
                Log(enLogLevel.Info, $"for: {i}");
                Thread.Sleep(_iThreadSleepTime);
            }

            DateTime endTime = DateTime.Now;
            Log(lboxTime, enLogLevel.Info, $"Thread End : {endTime - startTime}");
        }

        // Parallel For
        private void TpFor()
        {
            int iTotal = 0;

            Parallel.For(_iforStart, _iforCount, i =>      
            {
                Log(enLogLevel.Info, $"Parallel For : {i}");
                Thread.Sleep(_iThreadSleepTime);
            });

            DateTime endTime = DateTime.Now;
            Log(lboxTime, enLogLevel.Info,$"Thread End : {endTime - startTime}");

            /*
              Parallel.For(_iforStart, _iforCount, pfun);  

              Action<int> afun = pfun;

              public static void pfun(int a)
              {

              }
            */

            // 무명메서드
            /*
                Parallel.For(_iforStart, _iforCount, delegate(int i)
                {
                    Log(enLogLevel.Info, $"pfor(무명) : {i}");
                    Thread.Sleep(10);
                });
                */

            /*
                // 람다식
                Parallel.For(_iforStart, _iforCount, (i) =>
                {
                    Log(enLogLevel.Info, $"pfor(람다) : {i}");
                    Thread.Sleep(10);
                });
                */
        }

        // Parallel Foreach
        private void TpForeach()
        {
            /* ForEach는 List형태 같은걸 빼오니까 List생성 */

            //List<int> iList = (Enumerable.Repeat(3, 5)).ToList<int>();   // 초기화를 3,3,3,3,3
            List<int> iList = (Enumerable.Range(_iforStart, _iforCount)).ToList<int>();   // 선언 하면서 순차적으로 값 넣기

            Parallel.ForEach(iList, i =>
            {
                Log(enLogLevel.Info, $"Parallel Foreach : {i}");
                Thread.Sleep(_iThreadSleepTime);
            });

            DateTime endTime = DateTime.Now;
            Log(lboxTime, enLogLevel.Info, $"Thread End : {endTime - startTime}");
        }

        // Parallel Invoke(Function
        private void TpInvoke()
        {
            /* TpFor 함수와 TpForeach 함수 함께 호출한다고 보면 된다 */

            Parallel.Invoke(
                TpFor,
                TpForeach
            );
        }
        #endregion


        #region Log Viewer 
        enum enLogLevel
        {
            Info,
            Warning,
            Error,
        }

        private void Log(enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                DateTime dTime = DateTime.Now;
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
                Refresh();
            }));
        }

        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
            }));
        }

        private void Log(ListBox lbox, enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                DateTime dTime = DateTime.Now;
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lbox.Items.Insert(0, LogInfo);
            }));
        }
        #endregion
    }
}
