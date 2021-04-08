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

        public JsonResult<TemperatureConverterModel> GetConvertedTemperature(string unitInput, double valueInput)
        {
            TemperatureConverterModel tc = new TemperatureConverterModel();
            switch (unitInput)
            {
                case "celsius":
                    tc.Celsius = valueInput;
                    tc.Fahrenheit = (valueInput * 9) / 5 + 32;
                    tc.Kelvin = valueInput + 273.15;
                    break;
                case "kelvin":
                    tc.Celsius = valueInput - 273.15 ;
                    tc.Fahrenheit = (valueInput - 273.15) * 9 / 5 + 32;
                    tc.Kelvin = valueInput;
                    break;
                case "fahrenheit":
                    tc.Celsius = (valueInput - 32) * 5 / 9 ;
                    tc.Fahrenheit = valueInput;
                    tc.Kelvin = (valueInput - 32) * 5 / 9 + 273.15 ;
                    break;
                default:
                    break;
            
            }

            return Json(tc);
        }
        public JsonResult<LengthConverterModel> GetConvertedLengths(string unitInput, double valueInput)
        {
            LengthConverterModel lc = new LengthConverterModel();
            switch (unitInput.ToUpper())
            {
                case "KILOMETER":
                    lc.Kilometer = valueInput;
                    lc.Meter = valueInput * 1000;
                    lc.Centimeter = valueInput * 100000; 
                    lc.Millimetre = valueInput * 1e+6; 
                    lc.micrometres = valueInput * 1e+9; 
                    lc.Nanometre = valueInput * 1e+12; 
                    lc.Mile = valueInput / 1.609; 
                    lc.Yard = valueInput * 1094; 
                    lc.Foot = valueInput * 3281; 
                    lc.Inch = valueInput * 39370; 
                    lc.NauticalMile = valueInput / 1.852;
                    break;
                case "METER":
                    lc.Kilometer = valueInput / 1000;
                    lc.Meter = valueInput;
                    lc.Centimeter = valueInput * 100;
                    lc.Millimetre = valueInput * 1000;
                    lc.micrometres = valueInput * 1e+6;
                    lc.Nanometre = valueInput * 1e+9;
                    lc.Mile = valueInput / 1609;
                    lc.Yard = valueInput * 1.094;
                    lc.Foot = valueInput * 3.281;
                    lc.Inch = valueInput * 39.37;
                    lc.NauticalMile = valueInput / 1852;
                    break;
                case "CENTIMETER":
                    lc.Kilometer = valueInput / 100000;
                    lc.Meter = valueInput / 100;
                    lc.Centimeter = valueInput;
                    lc.Millimetre = valueInput * 10;
                    lc.micrometres = valueInput * 10000;
                    lc.Nanometre = valueInput * 1e+7;
                    lc.Mile = valueInput / 160934;
                    lc.Yard = valueInput / 91.44;
                    lc.Foot = valueInput / 30.48;
                    lc.Inch = valueInput / 2.54;
                    lc.NauticalMile = valueInput / 185200;
                    break; 
                case "MILLIMETRE":
                    lc.Kilometer = valueInput / 1e+6;
                    lc.Meter = valueInput / 1000;
                    lc.Centimeter = valueInput / 10;
                    lc.Millimetre = valueInput;
                    lc.micrometres = valueInput * 1000;
                    lc.Nanometre = valueInput * 1e+6;
                    lc.Mile = valueInput / 1.609e+6;
                    lc.Yard = valueInput / 914;
                    lc.Foot = valueInput / 305;
                    lc.Inch = valueInput / 25.4;
                    lc.NauticalMile = valueInput / 1.852e+6;
                    break;
                case "MICROMETRES":
                    lc.Kilometer = valueInput / 1e+9;
                    lc.Meter = valueInput / 1e+6 ;
                    lc.Centimeter = valueInput / 10000;
                    lc.Millimetre = valueInput / 1000;
                    lc.micrometres = valueInput;
                    lc.Nanometre = valueInput * 1000;
                    lc.Mile = valueInput / 1.609e+9;
                    lc.Yard = valueInput / 914400;
                    lc.Foot = valueInput / 304800;
                    lc.Inch = valueInput / 25400;
                    lc.NauticalMile = valueInput / 1.852e+9;
                    break;
                case "NANOMETRE":
                    lc.Kilometer = valueInput / 1e+12;
                    lc.Meter = valueInput / 1e+9;
                    lc.Centimeter = valueInput / 1e+7;
                    lc.Millimetre = valueInput / 1e+6;
                    lc.micrometres = valueInput / 1000;
                    lc.Nanometre = valueInput;
                    lc.Mile = valueInput / 1.609e+12;
                    lc.Yard = valueInput / 9.144e+8;
                    lc.Foot = valueInput / 3.048e+8;
                    lc.Inch = valueInput / 2.54e+7;
                    lc.NauticalMile = valueInput / 1.852e+12;
                    break; 
                case "MILE":
                    lc.Kilometer = valueInput * 1.609;
                    lc.Meter = valueInput * 1609;
                    lc.Centimeter = valueInput * 160934;
                    lc.Millimetre = valueInput * 1.609e+6;
                    lc.micrometres = valueInput * 1.609e+9;
                    lc.Nanometre = valueInput * 1.609e+12;
                    lc.Mile = valueInput;
                    lc.Yard = valueInput * 1760;
                    lc.Foot = valueInput * 5280;
                    lc.Inch = valueInput * 63360;
                    lc.NauticalMile = valueInput / 1.151;
                    break; 
                case "YARD":
                    lc.Kilometer = valueInput / 1094;
                    lc.Meter = valueInput / 1.094 ;
                    lc.Centimeter = valueInput * 91.44;
                    lc.Millimetre = valueInput * 914;
                    lc.micrometres = valueInput * 914400;
                    lc.Nanometre = valueInput * 9.144e+8;
                    lc.Mile = valueInput / 1760;
                    lc.Yard = valueInput;
                    lc.Foot = valueInput * 3;
                    lc.Inch = valueInput * 36;
                    lc.NauticalMile = valueInput / 2025;
                    break; 
                case "FOOT":
                    lc.Kilometer = valueInput / 3281;
                    lc.Meter = valueInput / 3.281 ;
                    lc.Centimeter = valueInput * 30.48;
                    lc.Millimetre = valueInput * 305;
                    lc.micrometres = valueInput * 304800;
                    lc.Nanometre = valueInput * 3.048e+8;
                    lc.Mile = valueInput / 5280;
                    lc.Yard = valueInput / 3;
                    lc.Foot = valueInput;
                    lc.Inch = valueInput * 12;
                    lc.NauticalMile = valueInput / 6076;
                    break; 
                case "INCH":
                    lc.Kilometer = valueInput;
                    lc.Meter = valueInput; ;
                    lc.Centimeter = valueInput;
                    lc.Millimetre = valueInput;
                    lc.micrometres = valueInput;
                    lc.Nanometre = valueInput;
                    lc.Mile = valueInput;
                    lc.Yard = valueInput;
                    lc.Foot = valueInput;
                    lc.Inch = valueInput;
                    lc.NauticalMile = valueInput;
                    break;
                case "NAUTICALMILE":
                    lc.Kilometer = valueInput;
                    lc.Meter = valueInput; ;
                    lc.Centimeter = valueInput;
                    lc.Millimetre = valueInput;
                    lc.micrometres = valueInput;
                    lc.Nanometre = valueInput;
                    lc.Mile = valueInput;
                    lc.Yard = valueInput;
                    lc.Foot = valueInput;
                    lc.Inch = valueInput;
                    lc.NauticalMile = valueInput;
                    break;
            }
            return Json(lc);
        }

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