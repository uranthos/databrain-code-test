# DataBrain Coding Test

Welcome to the DataBrain coding test. Please read these instructions carefully before starting. The first thing you need to do is fork this repo into your personal github account. Do not commit to the original source repository as you will give your answers away!

There are 3 parts to this test, you need to complete them all.

## 1. Unit test the class DataBrain.PAYG.PAYGService. 

The service has a single method:

`public float GetTax(float taxableIncome, PaymentFrequency frequency)`

This method calculates the amount of PAYG withholding for the supplied taxable income over the given period. The calculations are derived from the following document. 

https://www.ato.gov.au/uploadedFiles/Content/MEI/downloads/calculating-amounts-to-be-withheld-from-13-October-2020.pdf

As far as I know it is correct, the output should match what you get from here: https://paycalculator.com.au/ 

## 2. Expose the code through an API

- Please comment your code
- Both the API and the web front-end will be run on localhost (no CORS errors please)

## 3. Build a simple angular application that consumes the API

- It doesn't need to be fancy
- It does need to work :)
- Reorganise this repo so that the folder structure is neat and tidy
- Replace this readme file with a new one that describes your application structure and supplies any information that is needed to run your application. 

## How to submit 

- You should already have forked this repo into your personal github account.
- Commit your changes
- Give me access (github username: wallywasadog, github email: nick@databrain.com.au)
- Ping me to let me know you have completed the tasks

Have fun, and thank you for taking the time to complete this test.

