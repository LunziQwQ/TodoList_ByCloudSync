﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList {
    public partial class noticeForm : Form {
        private VisualManager visualManager = VisualManager.getInstance();
        public noticeForm() {
            InitializeComponent();
        }

        private void noticeForm_Load(object sender, EventArgs e) {
            NoticeText.Text = MessageNotice.getInstance().MessageText;
            Timer t = new Timer();
            
        }
    }
}
