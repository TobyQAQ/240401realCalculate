﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240401realCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float firstNumber, secondNumber; 
        int operators = -1;

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text = txtNumber.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }
            txtNumber.Text = txtNumber.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
            }

            txtNumber.Text = txtNumber.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 2;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 3;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); 
            txtNumber.Text = "0"; 
            operators = 0;
        }
    }
}
