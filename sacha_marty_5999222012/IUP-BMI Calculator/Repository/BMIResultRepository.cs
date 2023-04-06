﻿using IUP_BMI_Calculator.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Repository
{
    public class BMIResultRepository
    {
        string _dbPath;

        SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BMIResult>();
        }

        public BMIResultRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void AddNewBMIResult(string name, double height, double weight, double BMIScore, string BMIResult)
        {
            BMIResult result = new BMIResult();

           result.Weight = weight;
           result.Height = height;
           result.Name = name;
           result.BMI_score = BMIScore;
           result.Result = BMIResult;
           conn.Insert(result);

        }
    }
}
