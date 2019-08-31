using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    public class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message)
        {
            System.Windows.Forms.DialogResult dlResult = System.Windows.Forms.DialogResult.None;
            GUI.frmMessageOK msgOK = new GUI.frmMessageOK();
            msgOK.Width = 250;
            msgOK.lblMessage.Width = 250;
            msgOK.lblMessage.Location = new System.Drawing.Point(0, 66);
            msgOK.btnOK.Location = new System.Drawing.Point(44, 109);
            msgOK.pbImagen.Visible = false;
            msgOK.Message = message;
            dlResult = msgOK.ShowDialog();
            return dlResult;
        }

        public static System.Windows.Forms.DialogResult ShowMessage(string message,string caption,System.Windows.Forms.MessageBoxButtons button,System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (GUI.frmMessageOK msgOK = new GUI.frmMessageOK())
                    {
                        msgOK.Width = 376;
                        msgOK.lblMessage.Width = 376;
                        msgOK.lblMessage.Location = new System.Drawing.Point(0, 66);
                        msgOK.btnOK.Location = new System.Drawing.Point(104, 109);
                        msgOK.Caption = caption;
                        msgOK.Message = message;
                        
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgOK.MessageIcon = GestionBasica.Properties.Resources.Information;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgOK.MessageIcon = GestionBasica.Properties.Resources.Question;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgOK.MessageIcon = GestionBasica.Properties.Resources.Error;
                                break;
                        }
                        dlResult = msgOK.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (GUI.frmMessageYesNo msgYesNo = new GUI.frmMessageYesNo())
                    {
                        msgYesNo.Caption = caption;
                        msgYesNo.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = GestionBasica.Properties.Resources.Information;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = GestionBasica.Properties.Resources.Question;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = GestionBasica.Properties.Resources.Error;
                                break;
                        }
                        dlResult = msgYesNo.ShowDialog();
                    }
                    break;
            }
            return dlResult;
        }
    }
}
