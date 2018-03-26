using QuickType;
using System;
using System.Windows.Forms;

namespace RLStats
{
    public partial class Form1 : Form
    {
        Welcome _json;
        int currentIndex = 0;
        Control[] controlsCreated = new Control[];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateJson_Click(object sender, EventArgs e)
        {
            string filename = "rattletrap";
            string arguments = " --input \"" + txtReplayPath.Text + "\\" + txtReplayFile.Text + "\" > output.json";
            int timeout = 999999999;

            Workers.CreateJsonFile.Work(filename, arguments, timeout, txtReplayFile.Text.Replace(".replay", ""));
        }

        private void btnParseJson_Click(object sender, EventArgs e)
        {
            string jsonFilePath = txtReplayFile.Text.Replace(".replay", ".json");
            _json = Workers.FillObjectsFromJson.Work(jsonFilePath);
            tmrDraw.Start();
        }

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            Frame frame = _json.Content.Body.Frames[currentIndex];

            foreach (Replication rep in frame.Replications)
            {
                if (rep.Value != null)
                {
                    foreach (Updated upd in rep.Value.Updated)
                    {
                        if (upd.Value != null && upd.Value.RigidBodyState != null && upd.Value.RigidBodyState.Location != null)
                        {
                            
                        }
                    }
                }
            }
        }
    }
}
