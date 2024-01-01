import React from 'react'
import { useForm } from '../../hooks/useForm'

export const PermissionForm = ({ id }) => {
  const [formValues, hanldeInputChange] = useForm()

  console.log(id)

  const handleSubmit = (e) => {
    e.preventDefault()
    console.log(formValues)
  }

  return (
    <div className='form-permission'>
      <form onSubmit={ handleSubmit }>
        <div className='form-control'>
          <div className="form-group input-field">
            <label>EmployeeName</label>
            <input
              className="form-control"
              name='employeeName'
              placeholder="Employee name"
              onChange={ hanldeInputChange }
            />
          </div>

          <div className="form-group input-field">
            <label>EmployeeLastname</label>
            <input
              className="form-control"
              name='employeeLastname'
              placeholder="Employee Lastname"
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
              onChange={ hanldeInputChange }
            />
          </div>

          <div className="form-group input-field">
            <label>PermissionType</label>
            <input
              className="form-control"
              name='permissionType'
              type='number'
              min="0"
              placeholder="Permission Type"
              onChange={ hanldeInputChange }
            />
          </div>

          <button type="submit" className="btn btn-primary input-field">Submit</button>
        </div>
      </form>
    </div>
  )
}
