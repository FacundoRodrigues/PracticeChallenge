import React from 'react'
// import permissionMock from '../../mock/ListPermissionResponseMock.json'
import { PermissionCard } from './PermissionCard'
import { usePermissions } from '../../hooks/usePermissions'

export const PermissionList = () => {
  const [permissions, error] = usePermissions()

  console.log(error)

  return (
    <>
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

    {
      !!error &&
      <div className="alert alert-danger">
        <p className='alert-title'>{error}</p>
      </div>
    }
    </>
  )
}
