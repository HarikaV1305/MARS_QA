﻿using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;
using static MarsQA_1.Helpers.ConstantHelpers;

namespace MarsQA_1.Utils
{


    [Binding]
   
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();            
             ExcelLibHelper.PopulateInCollection(getCodeDirectory() + @"\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.SigninStep();
           
         
        }

        [AfterScenario]
        public void TearDown()
        {
            ExtentReports();
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
           test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();

            // end test. (Reports)
            Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            Extent.Flush();
           

        }
    }
}