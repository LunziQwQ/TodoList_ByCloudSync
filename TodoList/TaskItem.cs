﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList {
    class TaskItem {
        private const int maxTitleLength = 30;
        private const int maxTextLength = 255;

        private string title;
        private string moreText;
        public bool isStar;
        public int index;

        public string Title {
            get { return title; }
            set {
                if (value.Length <= maxTitleLength)
                    title = value;
                else
                    VisualManager.getInstance().sendNotice("Error:TitleLength out of the MaxTitleLength.");
            }
        }

        public string MoreText {
            get { return moreText; }
            set {
                if (value.Length <= maxTextLength)
                    moreText = value;
                else
                    VisualManager.getInstance().sendNotice("Error:TextLength out of the MaxTextLength.");
            }
        }

        public bool stringToItem(string itemContent) {
            string[] temp = itemContent.Split(new char[] {'#'});
            try {
                index = Int32.Parse(temp[0].Substring(6));
                isStar = Boolean.Parse(temp[1].Substring(7));
                title = temp[2].Substring(6);
                moreText = temp[3].Substring(9);
            }catch(Exception e) {
                return false;
            }
            return true;
        }

        public string itemToString() {
            return String.Format("index:%d&isStar:%b&title:%s&moreText:%s\n", index, isStar, title, MoreText);
        }

    }
}
