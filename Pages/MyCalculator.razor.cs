using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MyFrontendApp.Models;

namespace MyFrontendApp.Pages
{
    public partial class MyCalculator
    {
            string input1;
            string input2;
            string hasil;
            void Penambahan()
            {
                hasil = (Convert.ToDouble(input1) + Convert.ToDouble(input2)).ToString();
            }
            void Pengurangan()
            {
                hasil = (Convert.ToDouble(input1) - Convert.ToDouble(input2)).ToString();
            }
            void Perkalian()
            {
                hasil = (Convert.ToDouble(input1) * Convert.ToDouble(input2)).ToString();
            }
            void Pembagian()
            {
                if (Convert.ToDouble(input2) != 0)
                {
                    hasil = (Convert.ToDouble(input1) / Convert.ToDouble(input2)).ToString();
                }
                else
                {
                    hasil = "Tak Terhingga";
                }
            }
    }
}