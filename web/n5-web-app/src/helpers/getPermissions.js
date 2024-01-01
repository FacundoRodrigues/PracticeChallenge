export const getPermissions = async (category) => {
  const url = 'https://localhost:7280/permission'
  let permissions
  await fetch(url)
    .then(res => res.json())
    .then(data => {
      permissions = data
    })

  const result = permissions.map(permission => {
    return {
      id: permission.id,
      employeeName: permission.employeeName,
      employeeLastName: permission.employeeLastName,
      permissionDate: permission.permissionDate,
      permissionType: {
        id: permission.permissionType.id,
        description: permission.permissionType.description
      }
    }
  })

  return result
}

export const getPermissionsWithAxios = async (category) => {
  const url = 'https://localhost:7280/permission'

  const axios = require('axios')
  axios.get(url)
    .then(function (response) {
    // handle success
      console.log(response)
    })
    .catch(function (error) {
    // handle error
      console.log(error)
    })
    .finally(function () {
    // always executed
    })

  return {}
}
