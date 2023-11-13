import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, ParamMap } from '@angular/router';
import { ApiService } from '../api.service';
import { Observable } from 'rxjs';
import { Member, Score } from 'src/models/memberModel';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-member-page',
  templateUrl: './member-page.component.html',
})
export class MemberPageComponent implements OnInit {

  member!: Member;
  isLoading: boolean = true;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private apiService: ApiService
  ) { }

  async ngOnInit(): Promise<void> {
    const memberId = this.route.snapshot.paramMap.get('id');

    if(environment.production){
      (await this.apiService.GetMember(memberId!)).subscribe(res => {
        this.member = res;
      })
    }
    else{
      this.member = this.getMember()
    }
    this.isLoading = false;
  }

  private getMember(){
    
    var scores: Score[] =[];
    var score1: Score = {
      scoreId: 1,
      weekNumber: 1,
      hole1Score: 4,
      hole2Score: 3,
      hole3Score: 5,
      hole4Score: 5,
      hole5Score: 15,
      hole6Score: 1,
      hole7Score: 6,
      hole8Score: 3,
      hole9Score: 4,
      memberId: 1
    }
    var score2: Score = {
      scoreId: 2,
      weekNumber: 2,
      hole1Score: 4,
      hole2Score: 3,
      hole3Score: 5,
      hole4Score: 5,
      hole5Score: 16,
      hole6Score: 1,
      hole7Score: 6,
      hole8Score: 3,
      hole9Score: 4,
      memberId: 1
    }

    scores.push(score1, score2)

    var member1: Member = {
        memberId: 1,
        firstName: "Anthony",
        lastName: "Huck",
        handicap: 19,
        leagueId: 1,
        scores: scores
    }
console.log("###############", member1)
    return member1;
  }

}
