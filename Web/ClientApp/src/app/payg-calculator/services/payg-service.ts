import { throwError as throwError, of as observableOf, Observable } from 'rxjs';
import { Inject } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PAYGResultModel, PAYGSubmissionModel } from '../models/payg-submission-model';
import { catchError } from 'rxjs/operators';

@Injectable()
export class paygService {
  private commonUrl: string = 'api/payg/';

  constructor(
    private _http: HttpClient,
    @Inject('BASE_URL') baseUrl: string
  ) {
    //this.commonUrl = baseUrl + this.commonUrl;
  }

  public handleError(error: HttpErrorResponse) {
    //just logging error to console - some server logging could be added
    console.error(error);
    return throwError(() => error || 'Server error');  
  }

  getTax(model: PAYGSubmissionModel): Observable<PAYGResultModel> {
    const completeUrl: string = this.commonUrl + 'calculatetax';
    return this._http
      .post<PAYGResultModel>(completeUrl,model).pipe(
        catchError(this.handleError));
  }
}
