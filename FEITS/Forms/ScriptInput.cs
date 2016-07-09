﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FEITS.Controller;

namespace FEITS.View
{
    public partial class ScriptInput : Form, IExportImportView
    {
        private ImportExportController cont;

        public ScriptInput()
        {
            InitializeComponent();
        }

        public void SetController(ImportExportController controller)
        {
            cont = controller;
        }

        public int CharacterCount
        {
            get { return TB_ScriptInput.TextLength; }
        }

        public string MessageText
        {
            get { return TB_ScriptInput.Text; }
            set { TB_ScriptInput.Text = value; }
        }

        public string StatusText
        {
            get { return LBL_Warning.Text; }
            set { LBL_Warning.Text = value; }
        }

        public bool AllowImport
        {
            get { return B_LoadScript.Enabled; }
            set
            {
                B_LoadScript.Enabled = value;

                if (B_LoadScript.Enabled)
                    B_LoadScript.DialogResult = DialogResult.OK;
                else
                    B_LoadScript.DialogResult = DialogResult.None;
            }
        }

        private void TB_ScriptInput_TextChanged(object sender, EventArgs e)
        {
            cont.OnImportMsgChanged();
        }
    }
}
