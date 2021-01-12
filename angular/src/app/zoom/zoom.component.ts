import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {ZoomMtg} from '@zoomus/websdk'

ZoomMtg.preLoadWasm();
ZoomMtg.prepareJssdk();


@Component({
  selector: 'app-zoom',
  templateUrl: './zoom.component.html',
  styleUrls: ['./zoom.component.scss']
})
export class ZoomComponent implements OnInit {
  token : string;
  userId : string;
  apiKey: string;
  apiSecret : string;
  username : string;
  meetingID : number = 0 ;
  meetingURL : string = '';
  meetingPassword : string = '';
  public meetConfig : any;
  public signature : any;
  constructor(public http : HttpClient) {


   }

  ngOnInit(): void {
    
  }

  save(){
    var formData = new FormData();
    formData.append('Token', this.token);
    formData.append('User_id', this.userId);
    this.http.post("https://localhost:44397/Zoom/CreateMeeting",formData).subscribe((res : any) => {
      var parsed = JSON.parse(res.content);
      console.log(parsed)
      this.meetingID = parsed.id;
      console.log( this.meetingID )
      this.meetingURL = parsed.start_url;
      console.log(this.meetingURL)
      this.meetingPassword = parsed.password
      console.log( this.meetingPassword)
      //this.meetingID = res.id;
      //console.log(res.id)
      //this.meetingURL = res.start_url;
      //console.log( this.meetingURL)
      //this.meetingPassword = res.password;
      //console.log(this.meetingPassword)
    });
    //this.http.get("https://localhost:44397/Zoom").subscribe((res) => {
    //    console.log(res)
    //  });

    //eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOm51bGwsImlzcyI6Ii03a3JrbmwwUU5HUTZIT2ZQOU03WVEiLCJleHAiOjE2MTA1MzEwMDcsImlhdCI6MTYxMDQ0NDYwOX0.wQ5txjzdIfVcp9yoON3ccWVTT9dDeuf8hDF36X2XkbU
  }
  setConfig(val : string){
    //-7krknl0QNGQ6HOfP9M7YQ
    //TCaNrnzrXQ8i5Hz6WWomAy6iOjMV5oyKpzkb
    //hasan alhallak
    this.meetConfig = {
      apiKey: this.apiKey,
      apiSecret: this.apiSecret,
      meetingNumber: val,
      userName : this.username,
      passWord: this.meetingPassword,
      leaveUrl: "http://localhost:4200",
      role: 1
    };
    this.signature = ZoomMtg.generateSignature({
      meetingNumber: this.meetConfig.meetingNumber,
      apiKey: this.meetConfig.apiKey,
      apiSecret: this.meetConfig.apiSecret,
      role: this.meetConfig.role,
      success: (res : any) => {
        console.log(res.result);
      }
    });
    
    ZoomMtg.init({
      leaveUrl: 'http://localhost:4200',
      isSupportAV: true,
      success: (res : any) => {
        ZoomMtg.join({
          meetingNumber: this.meetConfig.meetingNumber,
          userName: this.meetConfig.userName,
          signature: this.signature,
          apiKey: this.meetConfig.apiKey,
          userEmail: 'hasan_ak1996@hotmail.com',
          passWord: this.meetConfig.passWord,
          success: (res : any) => {
            console.log('join meeting success');
          },
          error: (res : any) => {
            console.log(res);
          }
        });
      },
      error: (res : any) => {
        console.log(res);
      }
    });
  }

  joinMeeting(){
    this.setConfig(this.meetingID.toString());
    document.getElementById('zmmtg-root').style.display = 'block'
  }

}
