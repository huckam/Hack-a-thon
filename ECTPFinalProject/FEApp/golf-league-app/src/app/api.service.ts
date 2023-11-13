import { Injectable, NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClient  } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable, of } from "rxjs";
import { Member } from 'src/models/memberModel';

@Injectable()
export class ApiService { 

    apiEndpoint = "http"

    constructor (
        private http: HttpClient
        ) {}
    

    public async GetMembers(leagueId : number): Promise<Observable<Member[]>>{
        return this.http.get<Member[]>(this.apiEndpoint + '/members' + leagueId)
    }

    public async GetMember(memberId: string): Promise<Observable<Member>>{
        
        return this.http.get<Member>(this.apiEndpoint + '/member' + memberId)
    }
}
