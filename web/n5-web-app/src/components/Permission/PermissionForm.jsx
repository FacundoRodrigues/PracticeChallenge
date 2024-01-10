import React, { useEffect, useState } from 'react'
import { useForm } from '../../hooks/useForm'
import { createPermission } from '../../helpers/createPermission'
import { modifyPermission } from '../../helpers/modifyPermission'
import { getPermissionById } from '../../helpers/getPermissionById'
import { useNavigate } from 'react-router-dom'

export const PermissionForm = ({
  id
}) => {
  // Si Id tiene valor, sería un update
  const isUpdate = id > 0
  const navigate = useNavigate()

  const [title, setTitle] = useState('')
  const [formValues, hanldeInputChange, reset, setFormValues] = useForm()

  useEffect(() => {
    if (isUpdate) {
      getPermissionById(id)
        .then(response => {
          console.log(response)
          setFormValues({
            employeeName: response.employeeName || '',
            employeeLastname: response.employeeLastName || '',
            permissionDate: response.permissionDate || '',
            permissionTypeId: response.permissionType?.id || 0
          })
        })
    }
  }, [])

  useEffect(() => {
    if (isUpdate) setTitle('Modify permission')
    else setTitle('Create permission')
  }, [])

  const handleSubmit = (e) => {
    e.preventDefault()
    const data = { ...formValues, id, permissionTypeId: parseInt(formValues.permissionTypeId, 10) }

    if (isUpdate) {
      modifyPermission(data)
      navigate('/')
    } else {
      createPermission(data)
      navigate('/')
    }
  }

  return (
    <>
    <h2 style={{ marginTop: '20px' }}>{title}</h2>
      <div className='form-permission'>
      <form onSubmit={ handleSubmit }>
        <div className='form-control'>
          <div className="form-group input-field">
            <label>EmployeeName</label>
            <input
              className="form-control"
              autoComplete='off'
              name='employeeName'
              placeholder="Employee name"
              value={ formValues.employeeName }
              onChange={ hanldeInputChange }
            />
          </div>

          <div className="form-group input-field">
            <label>EmployeeLastname</label>
            <input
              className="form-control"
              autoComplete='off'
              name='employeeLastname'
              placeholder="Employee Lastname"
              value={ formValues.employeeLastname }
              onChange={ hanldeInputChange }
            />
          </div>

          <div className="form-group input-field">
            <label>PermissionDate</label>
            <input
              className="form-control"
              name='permissionDate'
              type='datetime-local'
              placeholder="Permission Date"
              value={ formValues.permissionDate }
              onChange={ hanldeInputChange }
            />
          </div>

          <div className="form-group input-field">
            <label>PermissionTypeId</label>
            <input
              className="form-control"
              name='permissionTypeId'
              type='number'
              min="0"
              placeholder="Permission Type Id"
              value={ formValues.permissionTypeId }
              onChange={ hanldeInputChange }
            />
          </div>

          <button type="submit" className="btn btn-primary input-field">Submit</button>
        </div>
      </form>
      {/* {!!error && <p style={{ color: 'red' }}>{error}</p>} */}
    </div>

    </>
  )
}
