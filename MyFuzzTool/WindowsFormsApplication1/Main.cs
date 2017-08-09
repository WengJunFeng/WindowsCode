﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MyFuzzTool
{
    public partial class frmFileFuzz : Form
    {
        


        public frmFileFuzz()
        {
            InitializeComponent();
        }

        private void tbxSourceFile(object sender, EventArgs e)
        {
          //  if(ofSourceFile.S)
        }

        private void frmFileFuzz_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            //点击才发触发这个事件
            if (ofdSourceFile.ShowDialog() == DialogResult.OK)
            {
                tbxSourceFile1.Text = ofdSourceFile.FileName;
            }
        }

        private void btnTargetDirectory_Click(object sender, EventArgs e)
        {
            if (fbdTargetDirectory.ShowDialog() == DialogResult.OK)
            {
                tbxTargetDirectory.Text = fbdTargetDirectory.SelectedPath;
            }
        }

        private void btnCreateFiles_Click(object sender, EventArgs e)
        {
            //先根据SourceFile路劲读取文件
            //选择Fuzz是All file模式还是其他模式
            Read readFile = new Read(tbxSourceFile1.Text);
            //读取模式的判断
            if (rbtRegex.Checked == true)
            {
                return;
            }
            else if (rbtAllBytes.Checked == true || rbtDepth.Checked == true || rbtRange.Checked == true) {
                return;
            }



            //All bytes 模式
            if (rbtAllBytes.Checked == true)
            {

            }
            else if (rbtRange.Checked == true)
            {
                //Range of Bytes



            }
            else if (rbtDepth.Checked == true)
            {
                //Depth of Byte


            } else if (rbtRegex.Checked == true) {

            }

            //后面是各个模式日志清除方式

        }
    }
}
