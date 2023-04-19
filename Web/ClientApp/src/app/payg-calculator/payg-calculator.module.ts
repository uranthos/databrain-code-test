import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { PaygCalculatorComponent } from './components/payg-calculator/payg-calculator.component';
import { paygService } from './services/payg-service';


@NgModule({
  declarations: [
    PaygCalculatorComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [paygService],
  exports: [PaygCalculatorComponent]
})
export class PaygCalculatorModule { }
