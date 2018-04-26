using System.ComponentModel;
using System.Threading;

namespace StatePattern2
{
    public class LumberMan
    {
        State state;

        BackgroundWorker bw;

        public LumberMan()
        {
            state = WorkState.getInstance;
            bw = new BackgroundWorker();

            BindingBw();
            StartBw();
        }

        void BindingBw()
        {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += Bw_DoWork;
        }
        void StartBw()
        {
            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                Thread.Sleep(10000);
                ChangeState();
            }
        }
        void ChangeState()
        {
            state=state.ChangeState();
        }

        public string Talk()
        {
            return state.Talk();
        }
    }
}
