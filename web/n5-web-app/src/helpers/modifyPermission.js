export const modifyPermission = async (data) => {
  const body = JSON.stringify(data)

  const url = 'https://localhost:7280/permissions'

  let permissionUpdated
  fetch(url, {
    method: 'PUT',
    headers: {
      Accept: 'application/json',
      'Content-Type': 'application/json'
    },
    body
  })
    .then((response) => response.json())
    .then(data => {
      return data
    })
    .catch(err => {
      return err
    })

  return permissionUpdated
}
