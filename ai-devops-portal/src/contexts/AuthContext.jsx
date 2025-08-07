import { createContext, useContext, useState, useEffect } from 'react'

const AuthContext = createContext()

export function AuthProvider({ children }) {
  const [user, setUser] = useState(null)
  const [loading, setLoading] = useState(true)

  useEffect(() => {
    // Simulate authentication check
    const checkAuth = async () => {
      try {
        const savedUser = localStorage.getItem('aidevops_user')
        if (savedUser) {
          setUser(JSON.parse(savedUser))
        }
      } catch (error) {
        console.error('Error checking authentication:', error)
      } finally {
        setLoading(false)
      }
    }

    checkAuth()
  }, [])

  const login = async (credentials) => {
    try {
      // Simulate API call
      const mockUser = {
        id: '1',
        name: credentials.username,
        email: `${credentials.username}@aidevops.com`,
        role: credentials.username === 'admin' ? 'admin' : 'user',
        permissions: credentials.username === 'admin' 
          ? ['all'] 
          : ['dashboard', 'project-management', 'development']
      }

      localStorage.setItem('aidevops_user', JSON.stringify(mockUser))
      setUser(mockUser)
      return { success: true }
    } catch (error) {
      return { success: false, error: error.message }
    }
  }

  const logout = () => {
    localStorage.removeItem('aidevops_user')
    setUser(null)
  }

  const hasPermission = (module) => {
    if (!user) return false
    return user.permissions.includes('all') || user.permissions.includes(module)
  }

  const value = {
    user,
    login,
    logout,
    hasPermission,
    loading
  }

  return (
    <AuthContext.Provider value={value}>
      {children}
    </AuthContext.Provider>
  )
}

export function useAuth() {
  const context = useContext(AuthContext)
  if (!context) {
    throw new Error('useAuth must be used within an AuthProvider')
  }
  return context
}

