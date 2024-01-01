import React from 'react'
// import permissionMock from '../../mock/ListPermissionResponseMock.json'
import { PermissionCard } from './PermissionCard'
import { usePermissions } from '../../hooks/usePermissions'

export const PermissionList = () => {
  const permissions = usePermissions()

  return (
    <div className='card-grid permissions'>
      {
        permissions && permissions.map(permission =>
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
