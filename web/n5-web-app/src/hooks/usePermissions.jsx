import { useEffect, useState } from 'react'
import { getPermissions } from '../helpers/getPermissions'

export const usePermissions = () => {
  const [permissions, setPermissions] = useState([])

  useEffect(() => {
    getPermissions()
      .then(permissions => {
        setPermissions(permissions)
      })
  }, [permissions])

  return permissions
}
