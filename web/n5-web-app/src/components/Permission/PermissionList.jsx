import React from 'react'
import permissionMock from '../../mock/ListPermissionResponseMock.json'
import { PermissionCard } from './PermissionCard'

export const PermissionList = () => {
  const permissions = permissionMock

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
