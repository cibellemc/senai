import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GuardGuard implements CanActivate {

  constructor(private _router: Router) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    
    // Check if localStorage is available
    if (typeof localStorage !== 'undefined' && localStorage.getItem('token') !== null) {
      return true;
    }
    
    // Redirect to login if token is not available or localStorage is not defined
    this._router.navigate(['login']);
    return false;
  }
}
