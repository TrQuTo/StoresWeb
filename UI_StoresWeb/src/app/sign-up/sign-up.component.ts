import { Component, ViewChild } from '@angular/core';
import { FormControl, FormGroupDirective, NgForm, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { HeaderComponent } from '../header/header.component';
import { MatDialog } from '@angular/material/dialog';
import { LoginComponent } from '../login/login.component';
export class checkValidate implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrl: './sign-up.component.scss'
})
export class SignUpComponent {
  constructor(public dialog: MatDialog) { 

  }
  @ViewChild(HeaderComponent) headerComponent!: HeaderComponent;
  cfPass:string = "";
  Pass:string = "";
  email = new FormControl('', [Validators.required, Validators.email]);
  firstName = new FormControl('', [Validators.required]);
  lastName = new FormControl('', [Validators.required]);
  password = new FormControl('', [Validators.required]);
  phone = new FormControl('', [Validators.required]);

  passwordMatcher = new checkValidate();
  emailMatcher = new checkValidate();
  firstNameMatcher = new checkValidate();
  lastNameMatcher = new checkValidate();
  phoneMatcher = new checkValidate();

  openLoginDialog(enterAnimationDuration: string, exitAnimationDuration: string) {
    this.dialog.closeAll();
    this.dialog.open(LoginComponent, {
      width: '500px',
      height: '60%',
      enterAnimationDuration,
      exitAnimationDuration,
    });
  }
}
