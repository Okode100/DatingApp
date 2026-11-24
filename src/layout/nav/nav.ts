// @ts-ignore

import {Component, inject} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {AccountService} from '../../core/services/account-service';

@Component({
  selector: 'app-nav',
  imports: [FormsModule],
  templateUrl: './nav.html',
  styleUrl: './nav.css',
})

export class Nav {
   private accountService = inject(AccountService)
    protected creds:  any = {}
}


function login(this: any) {
  this.accountService.login(this.creds).subscribe({
    next: (result: any) => console.log(result),
    error: (error: { message: any; }) => alert(error.message)
  })

}


