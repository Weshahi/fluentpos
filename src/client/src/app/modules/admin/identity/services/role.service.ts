import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/internal/operators/map';
import { RoleApiService } from 'src/app/core/api/identity/role-api.service';
import { IResult } from 'src/app/core/models/wrappers/IResult';
import { PaginatedResult } from 'src/app/core/models/wrappers/PaginatedResult';
import { Role } from '../models/Role';
import { RoleParams } from '../models/RoleParams';

@Injectable()
export class RoleService {
  constructor(private api: RoleApiService) {}

  getRoles(RoleParams: RoleParams): Observable<PaginatedResult<Role>> {
    let params = new HttpParams();
    if (RoleParams.searchString)
      params = params.append('searchString', RoleParams.searchString);
    if (RoleParams.pageNumber)
      params = params.append('pageNumber', RoleParams.pageNumber.toString());
    if (RoleParams.pageSize)
      params = params.append('pageSize', RoleParams.pageSize.toString());
    if (RoleParams.orderBy)
      params = params.append('orderBy', RoleParams.orderBy.toString());
    return this.api
      .getAlls(params)
      .pipe(map((response: PaginatedResult<Role>) => response));
  }

  getRoleById(id: string): Observable<Role> {
    return this.api.getById(id).pipe(map((response: Role) => response));
  }

  createRole(Role: Role): Observable<IResult<Role>> {
    return this.api
      .create(Role)
      .pipe(map((response: IResult<Role>) => response));
  }

  updateRole(Role: Role): Observable<IResult<Role>> {
    return this.api
      .update(Role)
      .pipe(map((response: IResult<Role>) => response));
  }

  deleteRole(id: string): Observable<IResult<string>> {
    return this.api
      .delete(id)
      .pipe(map((response: IResult<string>) => response));
  }
}
