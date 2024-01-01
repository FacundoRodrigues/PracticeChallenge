export const modifyPermission = async (data) => {
  const body = JSON.stringify(data)

  console.log(body)
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
      console.log('s')
      return data
    })
    .catch(err => {
      console.log(err)
      return err
    })

  return permissionUpdated
}
