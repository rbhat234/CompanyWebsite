import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService 
{
  readonly APIUrl="https://localhost:44397/api";
  constructor(private http:HttpClient) { }


  getUserList():Observable<any[]>
  {
    return this.http.get<any>(this.APIUrl+'/Employees');
  }

  addUser(val:any)
  {
    return this.http.post<any>(this.APIUrl+'/Employees',val);
  }
  updateUser(val:any)
  {
    return this.http.put<any>(this.APIUrl+'/Employees',val);
  }
  deleteUser(val:any)
  {
    return this.http.delete<any>(this.APIUrl+'/Employees/'+val);
  }

  siginUser(val:any)
  {
    return this.http.put<any>(this.APIUrl+'/Employees',val);
  }
  getAllUsersList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'api/Employees/GetALLEmployees');
   }

//select 
//  CheckBoxValue(val:any)
//  {
//    return this.http.post<any>(this.APIUrl+'/Employees',val);
//  }


}
