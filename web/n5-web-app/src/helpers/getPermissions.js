export const getPermissions = async () => {
  const url = 'https://localhost:7280/permission'
  const response = await fetch(url)
  const { data } = await response.json()

  console.log(data)

  const permissions = data.map(permission => {
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

  return permissions
}
