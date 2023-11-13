import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MemberPageComponent } from './member-page/member-page.component';
import { ApiService } from './api.service';
import { HomePageComponent } from './home-page/home-page.component';

@NgModule({
  declarations: [
    HomePageComponent,
    MemberPageComponent,
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [
    ApiService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
