import { Injectable } from '@angular/core';
import { Response } from '@angular/http';
import { Observable } from 'rxjs/Rx';

@Injectable()
export class ExceptionService {

  constructor() { }

   catchBadResponse: (errorResponse: any) => Observable<any> = (errorResponse: any) => {
      // TODO : show error message using popup or toaster
      const res = <Response>errorResponse;
      const err = res.json();
      const emsg = err ?
      (err.error ? err.error : JSON.stringify(err)) :
      (res.statusText || 'unknown error');
      console.error(emsg);
      return Observable.throw(err);
  }


}
