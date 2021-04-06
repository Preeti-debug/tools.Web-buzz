using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using tools.Web_buzz.Models.Converter;

namespace tools.Web_buzz.Controllers.Web_Tools
{
    public class ConverterAPIController : ApiController
    {
        // GET api/<controller>

        public JsonResult<WeightConverterModel> GetConvertedWeights(string unitInput,double valueInput)
        {
            //return "test1";
            WeightConverterModel wc = new WeightConverterModel();
            
            switch (unitInput)
            {
                case "tonne":
                    wc.Grams = valueInput * 1e+6 ;
                    wc.KiloGrams = valueInput * 1000;
                    wc.Microgram = valueInput * 1e+12 ;
                    wc.MiliGram = valueInput * 1e+9;
                    wc.ImperialTon = valueInput / 1.016;
                    wc.USTon = valueInput * 1.102;
                    wc.Ounce = valueInput * 35274;
                    wc.Pound = valueInput * 2205;
                    wc.Stone = valueInput * 157;
                    wc.tonne = valueInput;
                    break;
                case "Kilogram":
                    wc.Grams = valueInput * 1000;
                    wc.KiloGrams = valueInput;
                    wc.Microgram = valueInput * 1e+9;
                    wc.MiliGram = valueInput * 1e+6;
                    wc.ImperialTon = valueInput / 1016;
                    wc.USTon = valueInput / 907;
                    wc.Ounce = valueInput * 35.274;
                    wc.Pound = valueInput * 2.205;
                    wc.Stone = valueInput / 6.35;
                    wc.tonne = valueInput / 1000;
                    break;
                case "gram":
                    wc.Grams = valueInput;
                    wc.KiloGrams = valueInput / 1000;
                    wc.Microgram = valueInput * 1e+6;
                    wc.MiliGram = valueInput * 1000;
                    wc.ImperialTon = valueInput / 1.016e+6;
                    wc.USTon = valueInput / 907185;
                    wc.Ounce = valueInput / 28.35;
                    wc.Pound = valueInput / 454;
                    wc.Stone = valueInput / 6350;
                    wc.tonne = valueInput / 1e+6;
                    break;
                case "miligram":
                    wc.Grams = valueInput / 1000;
                    wc.KiloGrams = valueInput / 1e+6;
                    wc.Microgram = valueInput * 1000;
                    wc.MiliGram = valueInput;
                    wc.ImperialTon = valueInput / 1.016e+9;
                    wc.USTon = valueInput / 9.072e+8;
                    wc.Ounce = valueInput / 28350;
                    wc.Pound = valueInput / 453592;
                    wc.Stone = valueInput / 6.35e+6;
                    wc.tonne = valueInput / 1e+9;
                    break;
                case "microgram":
                    wc.Grams = valueInput / 1e+6;
                    wc.KiloGrams = valueInput / 1e+9;
                    wc.Microgram = valueInput;
                    wc.MiliGram = valueInput / 1000;
                    wc.ImperialTon = valueInput / 1.016e+12;
                    wc.USTon = valueInput / 9.072e+11;
                    wc.Ounce = valueInput / 2.835e+7;
                    wc.Pound = valueInput / 4.536e+8;
                    wc.Stone = valueInput / 6.35e+9;
                    wc.tonne = valueInput / 1e+12;
                    break;
                case "ImT":
                    wc.Grams = valueInput * 1.016e+6;
                    wc.KiloGrams = valueInput * 1016;
                    wc.Microgram = valueInput * 1.016e+12;
                    wc.MiliGram = valueInput * 1.016e+9;
                    wc.ImperialTon = valueInput;
                    wc.USTon = valueInput * 1.12;
                    wc.Ounce = valueInput * 35840;
                    wc.Pound = valueInput * 2240;
                    wc.Stone = valueInput * 160;
                    wc.tonne = valueInput * 1.016;
                    break;
                case "udTon":
                    wc.Grams = valueInput * 907185;
                    wc.KiloGrams = valueInput * 907;
                    wc.Microgram = valueInput * 9.072e+11;
                    wc.MiliGram = valueInput * 9.072e+8;
                    wc.ImperialTon = valueInput / 1.12;
                    wc.USTon = valueInput;
                    wc.Ounce = valueInput * 32000;
                    wc.Pound = valueInput * 2000;
                    wc.Stone = valueInput * 143;
                    wc.tonne = valueInput / 1.102;
                    break;
                case "stone":
                    wc.Grams = valueInput * 6350;
                    wc.KiloGrams = valueInput * 6.35;
                    wc.Microgram = valueInput * 6.35e+9;
                    wc.MiliGram = valueInput * 6.35e+6;
                    wc.ImperialTon = valueInput / 160;
                    wc.USTon = valueInput / 143;
                    wc.Ounce = valueInput * 224;
                    wc.Pound = valueInput * 14;
                    wc.Stone = valueInput;
                    wc.tonne = valueInput / 157;
                    break;
                case "pound":
                    wc.Grams = valueInput * 454;
                    wc.KiloGrams = valueInput / 2.205;
                    wc.Microgram = valueInput * 4.536e+8;
                    wc.MiliGram = valueInput * 453592;
                    wc.ImperialTon = valueInput / 2240;
                    wc.USTon = valueInput / 2000;
                    wc.Ounce = valueInput * 16;
                    wc.Pound = valueInput;
                    wc.Stone = valueInput / 14;
                    wc.tonne = valueInput / 2205;
                    break; 
                case "ounce":
                    wc.Grams = valueInput * 28.35;
                    wc.KiloGrams = valueInput / 35.274;
                    wc.Microgram = valueInput * 2.835e+7;
                    wc.MiliGram = valueInput * 28350;
                    wc.ImperialTon = valueInput / 35840;
                    wc.USTon = valueInput / 32000;
                    wc.Ounce = valueInput;
                    wc.Pound = valueInput / 16;
                    wc.Stone = valueInput / 224;
                    wc.tonne = valueInput / 35274;
                    break;
                default:
                    break;

            }

            return Json(wc);

        }

        //public JsonResult<WeightConverterModel> GetConvertedTemperature(string unitInput, double valueInput)
        //{
        //    return Json();
        //}

            // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}