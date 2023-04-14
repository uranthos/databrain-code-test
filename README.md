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
- Add a readme to the API project and add any information you deem relevant


## 3. Build a simple angular application that consumes the API

- It doesn't need to be fancy
- It does need to work :)
- Add a readme to the web project and add any information you deem relevant

## How to submit 

- You should already have forked this repo into your personal github account.
- Commit your changes
- Give me access (github username: wallywasadog, github email: nick@databrain.com.au)
- Ping me to let me know you have completed the tasks


