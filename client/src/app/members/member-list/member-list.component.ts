import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Member } from 'src/app/_models/member';
import { Pitch } from 'src/app/_models/pitch';
import { MembersService } from 'src/app/_services/members.service';


@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {
  members: Member[] = [];

  constructor(private memberService: MembersService){}

  ngOnInit(): void
  {
    this.loadMembers();
  }

  loadMembers(){
    this.memberService.getMembers().subscribe({
      next: members => {this.members = members}
    })
  }
}
