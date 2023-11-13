import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { ApiService } from '../api.service';
import { Member } from 'src/models/memberModel';
import { AppComponent } from '../app.component';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-home',
  templateUrl: 'home-page.component.html',
})
export class HomePageComponent {

  isLoading: boolean = false;
  isLive: boolean = false;
  subscriptions: Subscription[] = [];
  leagueMembers: Member[] = [];

  constructor(
    private router: Router,
    private activatedRoute: ActivatedRoute,
    private apiService: ApiService
  ){}

  async ngOnInit(): Promise<void>{
   if(environment.production){
    (await this.apiService.GetMembers(1)).subscribe(res => {
      this.leagueMembers = res;
  })
   }
   else{
    this.leagueMembers = this.getMembers();
   }
    
    this.isLoading = false;
   
  }
 goToMemberScores(memberId: number){
  console.log("?????????????????????????/")
  this.router.navigate(['member-scores/', memberId])
 }

 
  private getMembers(){
    var member1: Member = {
      memberId: 1,
      firstName: "John",
      lastName: "Doe",
      handicap: 19,
      leagueId: 1,
    }
    var member2: Member = {
      memberId: 2,
      firstName:  "Anthony",
      lastName:  "Huck",
      handicap:  3000,
      leagueId:  1,
    }

    var memberList: Member[] = [];
    memberList.push(member1, member2)
    return memberList;
  }

}

