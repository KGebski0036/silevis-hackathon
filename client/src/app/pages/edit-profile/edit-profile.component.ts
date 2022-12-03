import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, NonNullableFormBuilder, Validators } from '@angular/forms';
import { ColdObservable } from 'rxjs/internal/testing/ColdObservable';
import { Member } from 'src/app/_models/member';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';
import { MembersService } from 'src/app/_services/members.service';



@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css']
})
export class EditProfileComponent implements OnInit {

  constructor(
    private memberService: MembersService,
    private accountService: AccountService,
    private fb: NonNullableFormBuilder) { }

  editProfileForm: FormGroup = this.fb.group({
    userName: this.fb.control("", [Validators.required, Validators.minLength(1), Validators.maxLength(100)]),
    photoUrl: this.fb.control("", [Validators.minLength(1)]),
    age: this.fb.control(0, [Validators.required, Validators.min(10), Validators.max(200)]),
    nickname: this.fb.control("", [Validators.minLength(1)]),
    gender: this.fb.control("", [Validators.minLength(1)]),
    country: this.fb.control("", [Validators.minLength(1)]),
  })

  onFormSubmit(formData: Member) {
    let editedMember = {
      ...this.currentMember,
      ...formData,
    }

    this.memberService.updateMember(editedMember).subscribe(
      (value) => {
            console.table(editedMember);
            console.table(value);
            this.currentMember = value;
            if (this.currentMember.userName != this.currentUser?.username) {
              if (this.currentMember != null && this.currentUser != null)
              this.accountService.setCurrentUser({token: this.currentUser?.token, username: this.currentMember.userName});
            }
      }
    )
  }

  currentUser?: User;
  currentMember?: Member;

  ngOnInit(): void {
    this.accountService.currentUser$.subscribe((user) => { 
      if(user==null) return; 
      this.currentUser = user

      this.memberService.getMember(user.username).subscribe((value)=> {
        if(value != null)
        this.currentMember = value;
      })
    });
  }



}
