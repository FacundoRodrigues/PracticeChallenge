export const getPermissionById = async (id) => {
  const url = `https://localhost:7280/permissions/${id}`
  let permission
  await fetch(url)
    .then(res => res.json())
    .then(data => {
      permission = data
    })

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
}
