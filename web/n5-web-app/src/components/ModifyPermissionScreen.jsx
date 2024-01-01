import React from 'react'
import { useParams } from 'react-router-dom'
import { PermissionForm } from './Permission/PermissionForm'

export const ModifyPermissionScreen = () => {
  const { permissionId } = useParams()

  return (
    <>
      <PermissionForm id={permissionId} />
    </>
  )
}
