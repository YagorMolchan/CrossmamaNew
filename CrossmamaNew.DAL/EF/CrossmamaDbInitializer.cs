using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CrossmamaNew.DAL.Entities.Sizes.Abstracts;
using CrossmamaNew.DAL.Entities.Sizes.Concretes;

namespace CrossmamaNew.DAL.EF
{
    public class CrossmamaDbInitializer:DropCreateDatabaseAlways<CrossmamaDbContext>
    {
        protected override void Seed(CrossmamaDbContext dbContext)
        {
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "18 RU",
                Height = "50",
                Age = "1 месяц",
                EUValue = "56 EU",
                UKValue = "2 UK",
                USAValue = "0/3 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "18 RU",
                Height = "56",
                Age = "2 месяцa",
                EUValue = "56 EU",
                UKValue = "2 UK",
                USAValue = "0/3 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "20 RU",
                Height = "62",
                Age = "3 месяцa",
                EUValue = "58 EU",
                UKValue = "2 UK",
                USAValue = "0/3 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "22 RU",
                Height = "68",
                Age = "3-6 месяцев",
                EUValue = "68 EU",
                UKValue = "2 UK",
                USAValue = "3/6 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "22 RU",
                Height = "74",
                Age = "6-9 месяцев",
                EUValue = "74 EU",
                UKValue = "2 UK",
                USAValue = "6/9 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "24 RU",
                Height = "80",
                Age = "1 год",
                EUValue = "80 EU",
                UKValue = "2 UK",
                USAValue = "S/M US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "24 RU",
                Height = "86",
                Age = "1,5 годa",
                EUValue = "86 EU",
                UKValue = "2 UK",
                USAValue = "2-2T US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "26 RU",
                Height = "92",
                Age = "2 годa",
                EUValue = "92 EU",
                UKValue = "3 UK",
                USAValue = "2-2T US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "26 RU",
                Height = "98",
                Age = "3 годa",
                EUValue = "1 EU",
                UKValue = "3 UK",
                USAValue = "3T US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "28 RU",
                Height = "104",
                Age = "4 годa",
                EUValue = "1 EU",
                UKValue = "3 UK",
                USAValue = "4T US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "28 RU",
                Height = "110",
                Age = "5 лет",
                EUValue = "2 EU",
                UKValue = "4 UK",
                USAValue = "4-5 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "30 RU",
                Height = "116",
                Age = "6 лет",
                EUValue = "2 EU",
                UKValue = "4 UK",
                USAValue = "5-6 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "30 RU",
                Height = "122",
                Age = "7 лет",
                EUValue = "5 EU",
                UKValue = "6 UK",
                USAValue = "7 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "32 RU",
                Height = "128",
                Age = "8 лет",
                EUValue = "5 EU",
                UKValue = "8 UK",
                USAValue = "7 US"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "32 RU",
                Height = "134",
                Age = "9 лет",
                EUValue = "7 EU",
                UKValue = "8 UK",
                USAValue = "S"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "34 RU",
                Height = "140",
                Age = "10 лет",
                EUValue = "7 EU",
                UKValue = "10 UK",
                USAValue = "S"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "36 RU",
                Height = "146",
                Age = "11 лет",
                EUValue = "9 EU",
                UKValue = "10 UK",
                USAValue = "S/M"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "36 RU",
                Height = "152",
                Age = "12 лет",
                EUValue = "9 EU",
                UKValue = "12 UK",
                USAValue = "M/L"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "40 RU",
                Height = "158",
                Age = "13 лет",
                EUValue = "11 EU",
                UKValue = "14 UK",
                USAValue = "L"
            });
            dbContext.Sizes.Add(new Before14ClotheSize
            {
                Value = "42 RU",
                Height = "164",
                Age = "14 лет",
                EUValue = "11-12 EU",
                UKValue = "16 UK",
                USAValue = "L"
            });

            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "XXS",
                MValue = "-",
                FValue = "-"
            });
            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "XS",
                MValue = "44",
                FValue = "40"
            });
            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "S",
                MValue = "46",
                FValue = "42"
            });
            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "M",
                MValue = "48",
                FValue = "44"
            });
            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "L",
                MValue = "50",
                FValue = "46"
            });
            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "XL",
                MValue = "52",
                FValue = "48"
            });
            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "XXL",
                MValue = "54-56",
                FValue = "50-52"
            });
            dbContext.Sizes.Add(new After14ClotheSize
            {
                Value = "XXXL",
                MValue = "58-60",
                FValue = "54-58"
            });

            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "9,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "10 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "10,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "11 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "11,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "12 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "12,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "13 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "13,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "14 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "14,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "15 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "15,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "16 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "16,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "17 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "17,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "18 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "18,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "19 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "19,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "20 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "20,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "21 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "21,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "22 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "22,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "23 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "23,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "23,8 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "24,2 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "24,6 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "25 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "25,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "26 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "26,3 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "26,7 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "27,1 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "27,6 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "28 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "28,4 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "28,8 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "29,3 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "29,7 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "30,1 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "30,5 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "31 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "31,4 см"
            });
            dbContext.Sizes.Add(new FootwearSize
            {
                Value = "32 см"
            });


        }
    }
}
