using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂试炼角色血量百分比 message
 */
public class ResSoulTrialHpMessage : Message 
{
	//灵魂试炼角色血量
	List<SoulTrialHp> _soulTrialHp = new List<SoulTrialHp>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵魂试炼角色血量
		SerializeUtils.WriteShort(stream, (short)_soulTrialHp.Count);

		foreach (var element in _soulTrialHp)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵魂试炼角色血量
		int _soulTrialHp_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulTrialHp_length; ++i) 
		{
			_soulTrialHp.Add(SerializeUtils.ReadBean<SoulTrialHp>(stream));
		}
	}
	
	/**
	 * get 灵魂试炼角色血量
	 * @return 
	 */
	public List<SoulTrialHp> GetSoulTrialHp()
	{
		return _soulTrialHp;
	}
	
	/**
	 * set 灵魂试炼角色血量
	 */
	public void SetSoulTrialHp(List<SoulTrialHp> soulTrialHp)
	{
		_soulTrialHp = soulTrialHp;
	}
	
	
	public override int GetId() 
	{
		return 204300;
	}
}