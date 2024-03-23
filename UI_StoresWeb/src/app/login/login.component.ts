import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialog, MatDialogContent, MatDialogRef, MatDialogTitle } from '@angular/material/dialog';
import { HeaderComponent } from '../header/header.component';
import { SignUpComponent } from '../sign-up/sign-up.component';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent implements OnInit {

  hide = true;
  @ViewChild(HeaderComponent) headerComponent!: HeaderComponent;
  constructor(public dialog: MatDialog) { 

  }
  ngOnInit(): void {
    this.lang = localStorage.getItem('lang') || 'English';
  }
  openSignupDialog(enterAnimationDuration: string, exitAnimationDuration: string) {
    this.dialog.closeAll();
    this.dialog.open(SignUpComponent, {
      width: '500px',
      height: '70%',
      enterAnimationDuration,
      exitAnimationDuration,
    });
  }
  lang: string = 'English';
  selectedLang(lang: any) {
    const selectLang = lang;
    localStorage.setItem('lang', selectLang.value);
    console.log(lang);
  }
}
