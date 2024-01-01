import React from 'react'
import { Link } from 'react-router-dom'
import PropTypes from 'prop-types'

export const PermissionCard = ({
  id,
  employeeName,
  employeeLastName,
  permissionDate,
  permissionType
}) => {
  return (
  <div>
    <div className="card ms-3" style={{ width: '15rem' }}>
      <div className="card-body">
        <h5 className="card-title">{ employeeName } {employeeLastName}</h5>
        <p className="card-text">{ permissionDate }</p>
        <p className="card-text"><strong>PermissionType: </strong>{ permissionType.description }</p>

        <Link
          className='btn btn-primary'
          to={`/permission/${id}`}
        >
          Modify
        </Link>
      </div>
    </div>
  </div>
  )
}

PermissionCard.propTypes = {
  id: PropTypes.number.isRequired,
  employeeName: PropTypes.string.isRequired,
  employeeLastName: PropTypes.string.isRequired,
  permissionDate: PropTypes.string.isRequired,
  permissionType: PropTypes.object.isRequired
}
