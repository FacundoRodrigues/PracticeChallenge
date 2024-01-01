import React from 'react'
import permissionMock from '../../mock/ListPermissionResponseMock.json'
import { PermissionCard } from './PermissionCard'
import { getPermissions } from '../../helpers/getPermissions'

export const PermissionList = () => {
  const permissions = permissionMock
  const p = getPermissions()
  console.log(p)

  return (
    <div className='card-grid permissions'>
      {
        permissions.map((permission) =>
          <PermissionCard
            key={ permission.id }
            { ...permission }
          >
          </PermissionCard>
        )
      }
    </div>
  )
}
