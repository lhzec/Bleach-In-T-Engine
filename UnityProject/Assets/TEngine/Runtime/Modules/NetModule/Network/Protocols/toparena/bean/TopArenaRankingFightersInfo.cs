using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场同级积分排行榜出战角色列表
 */
public class TopArenaRankingFightersInfo : IMessageSerialize 
{
	//角色id
	int _characterId;	
	//角色阶级
	int _characterStage;	
	//角色成长率
	int _growthLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _characterStage);
		//角色成长率
		SerializeUtils.WriteInt(stream, _growthLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_characterStage = SerializeUtils.ReadInt(stream);
		//角色成长率
		_growthLevel = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 角色阶级
	 */
	public int CharacterStage
	{
		set { _characterStage = value; }
	    get { return _characterStage; }
	}
	
	/**
	 * 角色成长率
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
}