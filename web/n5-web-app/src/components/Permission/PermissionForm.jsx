import React from 'react'
import { useForm } from '../../hooks/useForm'

export const PermissionForm = () => {
  const [formValues, hanldeInputChange] = useForm({})

  const handleSubmit = (e) => {
    e.preventDefault()
  }

  return (
    <div className='form-permission'>
      <form onSubmit={ handleSubmit }>
        <div className='form-control'>
          <div className="form-group input-field">
            <label>EmployeeName</label>
            <input
              className="form-control"
              placeholder="Employee name"
            />
          </div>

          <div className="form-group input-field">
            <label>EmployeeLastname</label>
            <input
              className="form-control"
              placeholder="Employee Lastname"
            />
          </div>

          <div className="form-group input-field">
            <label>PermissionDate</label>
            <input
              className="form-control"
              placeholder="Permission Date"
            />
          </div>

          <div className="form-group input-field">
            <label>permissionType</label>
            <input
              className="form-control"
              placeholder="Permission Type"
            />
          </div>

          <button type="submit" className="btn btn-primary input-field">Submit</button>
        </div>
      </form>
    </div>
  )
}
