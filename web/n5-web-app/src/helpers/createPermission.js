export const createPermission = async (data) => {
  const body = JSON.stringify(data)

  console.log(body)
  const url = 'https://localhost:7280/permissions'

  let permissionCreated
  fetch(url, {
    method: 'POST',
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

  return permissionCreated
}
