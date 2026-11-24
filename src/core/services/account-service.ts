import { Inject, Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';


@Injectable({
  providedIn: 'root',
})
export class AccountService {
  private http = Inject(HttpClient);

  private baseUrl = 'https://localhost:5001/api/';

  login(  creds: any) {
    return this.http.post(this.baseUrl + 'account/login', creds)
  }

}
