import { NgModule, Component, Inject, ViewChild, OnInit } from '@angular/core';
import { BrowserModule, HammerModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CareersComponent } from './careers/careers.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { Page404Component } from './page-404/page-404.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { StoryComponent } from './story/story.component';
import { TalentComponent } from './talent/talent.component';
import { TeamComponent } from './team/team.component';

import { MAT_DIALOG_DATA, MatDialogContent, MatDialogTitle } from '@angular/material/dialog';
import {MatGridListModule} from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatDividerModule } from '@angular/material/divider';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatChipsModule } from '@angular/material/chips';
export const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'story', component: StoryComponent },
  { path: 'team', component: TeamComponent },
  { path: 'careers', component: CareersComponent },
  { path: 'talent', component: TalentComponent },
  { path: '**', component: Page404Component }
];
@NgModule({
  declarations: [
    AppComponent,
    CareersComponent,
    HeaderComponent,
    HomeComponent,
    LoginComponent,
    Page404Component,
    SignUpComponent,
    StoryComponent,
    TalentComponent,
    TeamComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatDialogTitle,
    MatDialogContent,
    MatIconModule,
    MatInputModule,
    MatFormFieldModule,
    MatCheckboxModule,
    MatDividerModule,
    MatButtonModule,
    MatSelectModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MatChipsModule,
    MatGridListModule,
    HammerModule,
    RouterModule.forRoot(routes)
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
