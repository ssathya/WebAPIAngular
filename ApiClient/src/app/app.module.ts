import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AuthHttp, AuthConfig } from 'angular2-jwt';
import { Http, RequestOptions, HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { AuthService } from './services/auth.service';

const appRoutes: Routes = [
  { 'path': '', redirectTo: '/', pathMatch: 'full' },
  { 'path': 'home', component: AppComponent },
  { 'path': 'callback', redirectTo: '/', pathMatch: 'full' },
  { 'path': '**', redirectTo: '/', pathMatch: 'full' }
];

export function authHttpServiceFactory(http: Http, options: RequestOptions) {
  // return new AuthHttp(new AuthConfig(), http, options);
  return new AuthHttp(new AuthConfig({
    tokenName: 'token',
    tokenGetter: (() => sessionStorage.getItem('token')),
    globalHeaders: [{ 'Content-Type': 'application/json' }]
  }), http, options);
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    HttpModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
