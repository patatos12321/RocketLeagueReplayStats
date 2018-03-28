using QuickType;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RLStats
{
    public partial class Form1 : Form
    {
        Welcome _json;
        int currentIndex = 0;

        int ratioX;
        int ratioY;

        int plusPetitX = 0;
        int plusPetitY = 0;

        Dictionary<string, Control> controls = new Dictionary<string, Control>();

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

            int plusGrosX = 0;
            int plusGrosY = 0;
            foreach (string obj in _json.Content.Body.Objects)
            {
                
            }
            int courantX = 0;
            int courantY = 0;

            foreach (Frame frame in _json.Content.Body.Frames)
            {
                foreach (Replication rep in frame.Replications)
                {
                    if (rep.Value != null && rep.Value.Updated != null)
                    {
                        foreach (Updated upd in rep.Value.Updated)
                        {
                            if (upd.Value != null && upd.Value.RigidBodyState != null && upd.Value.RigidBodyState.Location != null)
                            {
                                courantX = int.Parse(upd.Value.RigidBodyState.Location.Y.ToString());
                                courantY = int.Parse(upd.Value.RigidBodyState.Location.X.ToString());

                                if (courantX > plusGrosX)
                                {
                                    plusGrosX = courantX;
                                }
                                else if(courantX < plusPetitX)
                                {
                                    plusPetitX = courantX;
                                }

                                if (courantY > plusGrosY)
                                {
                                    plusGrosY = courantY;
                                }
                                else if (courantY < plusPetitY)
                                {
                                    plusPetitY = courantY;
                                }
                            }
                        }
                    }
                }
            }

            ratioX = (plusGrosX - plusPetitX) / pan.Size.Width;
            ratioY = (plusGrosY - plusPetitY) / pan.Size.Height;

            tmrDraw.Start();
        }

        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            Frame frame = _json.Content.Body.Frames[currentIndex];

            foreach (Replication rep in frame.Replications)
            {
                if (rep.Value != null && rep.Value.Updated != null)
                {
                    foreach (Updated upd in rep.Value.Updated)
                    {
                        if (upd.Value != null && upd.Value.RigidBodyState != null && upd.Value.RigidBodyState.Location != null)
                        {
                            Control ctrl;
                            if(!controls.TryGetValue(rep.ActorId.Value.ToString(), out ctrl))
                            {
                                Label label = new Label();
                                label.Location = new Point(int.Parse(upd.Value.RigidBodyState.Location.Y.ToString()) / ratioX + (-plusPetitX / ratioX), int.Parse(upd.Value.RigidBodyState.Location.X.ToString()) / ratioY + (-plusPetitY / ratioY));
                                label.Size = new Size(50, 13);
                                label.Text = rep.ActorId.Value.ToString();
                                pan.Controls.Add(label);
                            }
                            else
                            {
                                ctrl.Location = new Point(int.Parse(upd.Value.RigidBodyState.Location.Y.ToString()), int.Parse(upd.Value.RigidBodyState.Location.X.ToString()));
                            }
                        }
                    }
                }
            }
        }
    }
}
