import { Component } from '@angular/core';
import { RouterModule, Router } from '@angular/router';
import {
  MatDialog,
  MAT_DIALOG_DATA,
  MatDialogTitle,
  MatDialogContent,
  MatDialogRef,
} from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { LoginComponent } from '../login/login.component';
import { SignUpComponent } from '../sign-up/sign-up.component';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
  constructor(private router: Router, public dialog: MatDialog) {

  }
  currentLink: string = '';
  ngOnInit(): void {
    this.currentLink = this.router.url;
  }
  //Mở pupop Login
  openLoginDialog(enterAnimationDuration: string, exitAnimationDuration: string) {
    this.dialog.open(LoginComponent, {
      width: '500px',
      height: '60%',
      enterAnimationDuration,
      exitAnimationDuration,
    });
  }
  //Mở pupop Sign in
  openSignupDialog(enterAnimationDuration: string, exitAnimationDuration: string) {
    this.dialog.open(SignUpComponent, {
      width: '500px',
      height: '70%',
      enterAnimationDuration,
      exitAnimationDuration,
    });
  }
}
