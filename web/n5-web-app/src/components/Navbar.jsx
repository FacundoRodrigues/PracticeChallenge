import React from 'react'
import { Link, NavLink } from 'react-router-dom'

export const Navbar = () => {
  return (
  <nav className="navbar navbar-expand-sm navbar-dark bg-dark">
    <Link
      className="navbar-brand"
      to="/"
    >
      Permissions
    </Link>
    <div className="navbar-collapse">
      <div className="navbar-nav">

        <NavLink
          className="nav-item nav-link"
          to="/permissions"
        >
          List
        </NavLink>

        <NavLink
          className="nav-item nav-link"
          to="/create"
        >
          Create
        </NavLink>
      </div>
    </div>
  </nav>
  )
}
