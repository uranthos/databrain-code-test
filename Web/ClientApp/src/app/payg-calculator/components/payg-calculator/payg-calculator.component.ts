
import { Component, OnInit } from '@angular/core';
import { PAYGSubmissionModel } from '../../models/payg-submission-model';
import { FormBuilder, FormGroup, FormGroupName, UntypedFormControl, UntypedFormGroup, Validators } from '@angular/forms';
import { paygService } from '../../services/payg-service';

@Component({
  selector: 'app-payg-calculator',
  templateUrl: './payg-calculator.component.html',
  styleUrls: ['./payg-calculator.component.css']
})
export class PaygCalculatorComponent implements OnInit {

  paymentFrequencies: string[] = ['Weekly', 'Fortnightly', 'Monthly', 'FourWeekly'];

  taxableIncome: UntypedFormControl = this.fb.control(0, [Validators.required]);
  frequency: UntypedFormControl = this.fb.control(0, [Validators.required]);

  result?: number;

  paygSubmission: FormGroup = this.fb.group({
    taxableIncome: this.taxableIncome,
    frequency: this.frequency
  }) as UntypedFormGroup;

  constructor(private fb: FormBuilder,
    private paygService: paygService) {
  }

  ngOnInit(): void {

  }

  fetchResults(): void {

    let model = this.paygSubmission.value as PAYGSubmissionModel;


    this.paygService.getTax(model).subscribe(output => {
      this.result=output.result;
    });

  }


}
