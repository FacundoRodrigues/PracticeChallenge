import { useEffect, useState } from 'react'
import { getPermissions } from '../helpers/getPermissions'

export const usePermissions = () => {
  const [permissions, setPermissions] = useState([])
  const [error, setError] = useState()

  useEffect(() => {
    getPermissions()
      .then(permissions => {
        setPermissions(permissions)
      })
      .catch(e => {
        setError(e.message)
      })
  }, [permissions])

  return [permissions, error]
}
