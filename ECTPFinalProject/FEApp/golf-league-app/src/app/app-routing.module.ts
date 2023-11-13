import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { MemberPageComponent } from './member-page/member-page.component';

const routes: Routes = [

  {
    path: "home-page", pathMatch: 'full', component: AppComponent,
    children: [
      { path: '', component: AppComponent}
    ]
  },
  {
    path: "member-scores/:memberId", pathMatch: 'full', component: MemberPageComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
